﻿using Newtonsoft.Json;
using System;

namespace WebAppSecurity.Authorization
{
    public class JwtToken
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("expires_at")]
        public DateTime ExpiresAt { get; set; }
    }
}
