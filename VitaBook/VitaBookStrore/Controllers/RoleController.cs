﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitaBookStrore.Models;
using VitaBookStrore.ViewModels;

namespace VitaBookStrore.Controllers
{
    
    
       [Microsoft.AspNetCore.Authorization.Authorize(Roles = ("Admin"))]
        public class RoleController : Controller
        {
            private RoleManager<IdentityRole> roleManager;
            public RoleController(RoleManager<IdentityRole> roleManager)
            {
                this.roleManager = roleManager;
            }
            public IActionResult Index()
            {
                var roles = roleManager.Roles;
                var model = new List<Role>();
                model = roles.Select(r => new Role()
                {
                    id = r.Id,
                    roleName = r.Name
                }).ToList();
                return View(model);
            }
            [HttpGet]
            public IActionResult Create()
            {
                return View();
            }
            [HttpPost]
            public async Task<IActionResult> Create(RoleCreateViewModel model)
            {
                if (ModelState.IsValid)
                {
                    var result = await roleManager.CreateAsync(new IdentityRole()
                    {
                        Name = model.RoleName
                    });
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Role");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                return View();

            }
            [HttpGet]
            public async Task<IActionResult> Edit(string id)
            {
                var role = await roleManager.FindByIdAsync(id);
                if (role != null)
                {
                    var model = new RoleEditViewModel()
                    {
                        id = role.Id,
                        roleName = role.Name
                    };

                    return View(model);
                }

                return View();
            }
            [HttpPost]
            public async Task<IActionResult> Edit(RoleEditViewModel model)
            {
                if (ModelState.IsValid)
                {
                    var role = await roleManager.FindByIdAsync(model.id);
                    if (role != null)
                    {
                        role.Name = model.roleName;
                        var result = await roleManager.UpdateAsync(role);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index", "Role");
                        }
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
                return View(model);
            }

            [HttpPost]
            public async Task<IActionResult> Delete(string id)
            {
                var role = await roleManager.FindByIdAsync(id);
                if (role != null)
                {
                    var result = await roleManager.DeleteAsync(role);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Role");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                return RedirectToAction("Index", "Role");
            }
        }
    }

