// ------------------------------------------------------------------------------
// Copyright 2014 Microsoft Corporation
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ------------------------------------------------------------------------------

using System;

namespace OAuthTest
{
    public static class OAuthConstants
    {
        #region OAuth 2.0 standard parameters
        public const string ClientID = "client_id";
        public const string ClientSecret = "client_secret";
        public const string Callback = "redirect_uri";
        public const string ClientState = "state";
        public const string Scope = "scope";
        public const string Code = "code";
        public const string AccessToken = "access_token";
        public const string AuthenticationToken = "authentication_token";
        public const string ExpiresIn = "expires_in";
        public const string RefreshToken = "refresh_token";
        public const string ResponseType = "response_type";
        public const string GrantType = "grant_type";
        public const string Error = "error";
        public const string ErrorDescription = "error_description";
        public const string Display = "display";
        #endregion
    }
}