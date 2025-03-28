﻿using Application.CQRS.Identity.Password;
using Application.CQRS.Identity.Users;
using Application.Interfaces.Identity;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Constants;

namespace IGift2.Controllers.APIs
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAll")]
        [Authorize(Roles = AppConstants.Role.AdministratorRole)]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await _userService.GetAllAsync());
        }

        [HttpPost("GetById")]
        //[Authorize(Roles = AppConstants.Role.AdministratorRole)]
        public async Task<ActionResult> GetById(UserByIdRequest request)
        {
            return Ok(await _userService.GetByIdAsync(request.UserId));
        }

        [HttpGet("GetRolesFromUserId")]
        [Authorize(Roles = AppConstants.Role.AdministratorRole)]
        public async Task<ActionResult> GetAllRoles(string Id)
        {
            return Ok(await _userService.GetRolesAsync(Id));
        }

        [HttpPost("Register")]
        public async Task<ActionResult> Register(UserCreateRequest m)
        {
            return Ok(await _userService.RegisterAsync(m));
        }

        [HttpPost("ForgotPassword")]
        public async Task<ActionResult> ForgotPasswordAsync(ForgotPasswordRequest request)
        {
            return Ok(await _userService.ForgotPasswordAsync(request, Request.Headers["origin"]!));
        }

        [HttpPost("ChangeUserStatus")]
        public async Task<ActionResult> ChangeUserStatus(ChangeUserRequest request)
        {
            return Ok(await _userService.ChangeUserStatus(request));
        }

        [HttpPost("UpdateRolesFromUser")]
        public async Task<ActionResult> UpdateRolesFromUser(UpdateUserRolesRequest request)
        {
            return Ok(await _userService.UpdateRolesAsync(request));
        }
    }
}
