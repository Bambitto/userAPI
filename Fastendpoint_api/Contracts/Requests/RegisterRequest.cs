﻿namespace Fastendpoint_api.Contracts.Requests
{
    public class RegisterRequest
    {
        public string? Username { get; init; }
        public string? Password { get; init; }
        public string? Email { get; init; }
    }
}
