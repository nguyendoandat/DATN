﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Project.Data.Entities;

namespace Project.web.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(SignInManager<AppUser> signInManager, 
            ILogger<LoginModel> logger,
            UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "UserName không được để trống")]
            //[EmailAddress(ErrorMessage = "Email nhập không đúng định dạng")]
            public string UserName { get; set; }

            [Required(ErrorMessage = "Mật khẩu không được để trống")]
            [DataType(DataType.Password)]
            [MaxLength(20, ErrorMessage = "Password chỉ từ 8-20 ký tự")]
            [MinLength(8, ErrorMessage = "Password chỉ từ 8-20 ký tự")]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl ??= Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        
            if (/*ModelState.IsValid*/true)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.UserName, Input.Password, Input.RememberMe, true);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");

                    var currentUser = _userManager.Users.FirstOrDefault(u => u.UserName == Input.UserName);
                    if(currentUser != null)
                    {
                        var checkRole = await _userManager.IsInRoleAsync(currentUser, "Admin");

                        if (checkRole)
                        {
                            return LocalRedirect("/admin/Home/Index");
                        }
                        var checkRole2 = await _userManager.IsInRoleAsync(currentUser, "Shipper");
                        if (checkRole2)
                        {
                            return LocalRedirect("/admin/ShipperOrder/Index");
                        }
                        return LocalRedirect(returnUrl);
                    }
                    
                    return LocalRedirect(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {

                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                else if (result.IsLockedOut)
                {
                    _logger.LogWarning("Tài khoản bạn tạm thời khóa 5 phút.");
                    //return RedirectToPage("./Lockout");
                    ModelState.AddModelError("","Tài khoản bạn tạm thời khóa 5 phút.");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Tài khoản hoặc mật khẩu không chính xác");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
