﻿global using AspNetCoreRateLimit;
global using Autofac;
global using Autofac.Extensions.DependencyInjection;
global using AutoMapper;
global using CSRedis;
global using Jaina;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.Controllers;
global using Microsoft.AspNetCore.Mvc.Filters;
global using Microsoft.AspNetCore.Server.Kestrel.Core;
global using Microsoft.AspNetCore.StaticFiles;
global using Microsoft.Extensions.FileProviders;
global using Microsoft.IdentityModel.Tokens;
global using Microsoft.OpenApi.Models;
global using NET.Api.Attributes;
global using NET.Api.Filters;
global using NET.Api.Services;
global using NET.Api.Subscribers;
global using NET.Domain.Dtos;
global using NET.Domain.Entities;
global using NET.Domain.Enums;
global using NET.Domain.ViewModels;
global using NET.Infrastructure.Fleck;
global using NET.Infrastructure.Repositories;
global using NET.Infrastructure.Tools;
global using Serilog;
global using Serilog.Events;
global using SqlSugar;
global using Swashbuckle.AspNetCore.SwaggerUI;
global using System.Diagnostics;
global using System.IdentityModel.Tokens.Jwt;
global using System.Net;
global using System.Reflection;
global using System.Security.Claims;
global using System.Text;
global using System.Text.Encodings.Web;
global using System.Text.Json.Serialization;
global using System.Text.Unicode;
global using System.Threading.Channels;
global using System.Xml.Linq;