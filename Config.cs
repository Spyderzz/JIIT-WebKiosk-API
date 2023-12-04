// BLOCK: Http Request
data.ExecutingBlock("Http Request");
await HttpRequestStandard(data, new StandardHttpRequestOptions{Content = $"{{\"otppwd\":\"PWD\",\"username\":\"{input.USER}\",\"passwordotpvalue\":\"{input.PASS}\",\"Modulename\":\"STUDENTMODULE\"}}", ContentType = "application/x-www-form-urlencoded", UrlEncodeContent = false, Url = "https://webportal.jiit.ac.in:6011/StudentPortalAPI/token/generate-token1", Method = RuriLib.Functions.Http.HttpMethod.POST, AutoRedirect = true, MaxNumberOfRedirects = 8, ReadResponseContent = true, AbsoluteUriInFirstLine = false, HttpLibrary = RuriLib.Functions.Http.Options.HttpLibrary.RuriLibHttp, SecurityProtocol = RuriLib.Functions.Http.SecurityProtocol.SystemDefault, CustomCookies = new Dictionary<string, string>{}, CustomHeaders = new Dictionary<string, string>{{"Host", "webportal.jiit.ac.in:6011"}, {"Connection", "keep-alive"}, {"sec-ch-ua", "\"Chromium\";v=\"116\", \"Not)A;Brand\";v=\"24\", \"Google Chrome\";v=\"116\""}, {"DNT", "1"}, {"sec-ch-ua-mobile", "?0"}, {"Authorization", "Bearer"}, {"User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " + "Chrome/116.0.0.0 Safari/537.36"}, {"Content-Type", "application/json"}, {"Accept", "application/json, text/plain, */*"}, {"sec-ch-ua-platform", "\"Windows\""}, {"Origin", "https://webportal.jiit.ac.in:6011"}, {"Sec-Fetch-Site", "same-origin"}, {"Sec-Fetch-Mode", "cors"}, {"Sec-Fetch-Dest", "empty"}, {"Referer", "https://webportal.jiit.ac.in:6011/studentportal/"}, {"Accept-Language", "en-GB,en-US;q=0.9,en;q=0.8,hi;q=0.7"}, {"Accept-Encoding", "gzip, deflate"}}, TimeoutMilliseconds = 15000, HttpVersion = "1.1", CodePagesEncoding = "", AlwaysSendContent = false, DecodeHtml = false, UseCustomCipherSuites = false, CustomCipherSuites = new List<string>{"TLS_AES_128_GCM_SHA256", "TLS_CHACHA20_POLY1305_SHA256", "TLS_AES_256_GCM_SHA384", "TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256", "TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256", "TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256", "TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256", "TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384", "TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384", "TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA", "TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA", "TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA", "TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA", "TLS_RSA_WITH_AES_128_GCM_SHA256", "TLS_RSA_WITH_AES_256_GCM_SHA384", "TLS_RSA_WITH_AES_128_CBC_SHA", "TLS_RSA_WITH_AES_256_CBC_SHA", "TLS_RSA_WITH_3DES_EDE_CBC_SHA"}}).ConfigureAwait(false);

// BLOCK: Parse
data.ExecutingBlock("Parse");
string tk = ParseBetweenStrings(data, data.SOURCE.AsString(), "token\":\"", "\"", true, "", "", false);
data.LogVariableAssignment(nameof(tk));

// BLOCK: Parse
data.ExecutingBlock("Parse");
string tk2 = ParseBetweenStrings(data, data.SOURCE.AsString(), "\"value\":\"", "\"", true, "", "", false);
data.LogVariableAssignment(nameof(tk2));

// BLOCK: Http Request
data.ExecutingBlock("Http Request");
await HttpRequestStandard(data, new StandardHttpRequestOptions{Content = $"{{\"clientid\":\"JAYPEE\",\"instituteid\":\"{tk2}\",\"membertype\":\"S\"}}", ContentType = "application/x-www-form-urlencoded", UrlEncodeContent = false, Url = "https://webportal.jiit.ac.in:6011/StudentPortalAPI/StudentClassAttendance/getstud" + "entInforegistrationforattendence", Method = RuriLib.Functions.Http.HttpMethod.POST, AutoRedirect = true, MaxNumberOfRedirects = 8, ReadResponseContent = true, AbsoluteUriInFirstLine = false, HttpLibrary = RuriLib.Functions.Http.Options.HttpLibrary.RuriLibHttp, SecurityProtocol = RuriLib.Functions.Http.SecurityProtocol.SystemDefault, CustomCookies = new Dictionary<string, string>{}, CustomHeaders = new Dictionary<string, string>{{$"Host", $"webportal.jiit.ac.in:6011"}, {$"Connection", $"keep-alive"}, {$"sec-ch-ua", $"\"Chromium\";v=\"116\", \"Not)A;Brand\";v=\"24\", \"Google Chrome\";v=\"116\""}, {$"DNT", $"1"}, {$"sec-ch-ua-mobile", $"?0"}, {$"Authorization", $"Bearer {tk}"}, {$"User-Agent", $"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36"}, {$"Content-Type", $"application/json"}, {$"Accept", $"application/json, text/plain, */*"}, {$"sec-ch-ua-platform", $"\"Windows\""}, {$"Origin", $"https://webportal.jiit.ac.in:6011"}, {$"Sec-Fetch-Site", $"same-origin"}, {$"Sec-Fetch-Mode", $"cors"}, {$"Sec-Fetch-Dest", $"empty"}, {$"Referer", $"https://webportal.jiit.ac.in:6011/studentportal/"}, {$"Accept-Language", $"en-GB,en-US;q=0.9,en;q=0.8,hi;q=0.7"}, {$"Accept-Encoding", $"gzip, deflate"}}, TimeoutMilliseconds = 15000, HttpVersion = "1.1", CodePagesEncoding = "", AlwaysSendContent = false, DecodeHtml = false, UseCustomCipherSuites = false, CustomCipherSuites = new List<string>{"TLS_AES_128_GCM_SHA256", "TLS_CHACHA20_POLY1305_SHA256", "TLS_AES_256_GCM_SHA384", "TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256", "TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256", "TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256", "TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256", "TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384", "TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384", "TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA", "TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA", "TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA", "TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA", "TLS_RSA_WITH_AES_128_GCM_SHA256", "TLS_RSA_WITH_AES_256_GCM_SHA384", "TLS_RSA_WITH_AES_128_CBC_SHA", "TLS_RSA_WITH_AES_256_CBC_SHA", "TLS_RSA_WITH_3DES_EDE_CBC_SHA"}}).ConfigureAwait(false);

// BLOCK: Parse
data.ExecutingBlock("Parse");
string iid = ParseBetweenStrings(data, data.SOURCE.AsString(), "\"registrationid\":\"", "\"", true, "", "", false);
data.LogVariableAssignment(nameof(iid));

// BLOCK: Parse
data.ExecutingBlock("Parse");
string Name = ParseBetweenStrings(data, data.SOURCE.AsString(), "\"name\":\"", "\"", true, "", "", false);
data.LogVariableAssignment(nameof(Name));
data.MarkForCapture(nameof(Name));

// BLOCK: Parse
data.ExecutingBlock("Parse");
string Branch = ParseBetweenStrings(data, data.SOURCE.AsString(), "branchdesc\":\"", "\"", true, "", "", false);
data.LogVariableAssignment(nameof(Branch));
data.MarkForCapture(nameof(Branch));

// BLOCK: Parse
data.ExecutingBlock("Parse");
string Semester = ParseBetweenStrings(data, data.SOURCE.AsString(), "semlist\":[{\"registrationcode\":\"", "\"", true, "", "", false);
data.LogVariableAssignment(nameof(Semester));
data.MarkForCapture(nameof(Semester));

// BLOCK: Http Request
data.ExecutingBlock("Http Request");
await HttpRequestStandard(data, new StandardHttpRequestOptions{Content = $"{{\"clientid\":\"JAYPEE\",\"instituteid\":\"{tk2}\",\"stynumber\":\"1\",\"registrationid\":\"{iid}\"}}", ContentType = "application/x-www-form-urlencoded", UrlEncodeContent = false, Url = "https://webportal.jiit.ac.in:6011/StudentPortalAPI/StudentClassAttendance/getstud" + "entattendancedetail", Method = RuriLib.Functions.Http.HttpMethod.POST, AutoRedirect = true, MaxNumberOfRedirects = 8, ReadResponseContent = true, AbsoluteUriInFirstLine = false, HttpLibrary = RuriLib.Functions.Http.Options.HttpLibrary.RuriLibHttp, SecurityProtocol = RuriLib.Functions.Http.SecurityProtocol.SystemDefault, CustomCookies = new Dictionary<string, string>{}, CustomHeaders = new Dictionary<string, string>{{$"Host", $"webportal.jiit.ac.in:6011"}, {$"Connection", $"keep-alive"}, {$"sec-ch-ua", $"\"Chromium\";v=\"116\", \"Not)A;Brand\";v=\"24\", \"Google Chrome\";v=\"116\""}, {$"DNT", $"1"}, {$"sec-ch-ua-mobile", $"?0"}, {$"Authorization", $"Bearer {tk}"}, {$"User-Agent", $"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36"}, {$"Content-Type", $"application/json"}, {$"Accept", $"application/json, text/plain, */*"}, {$"sec-ch-ua-platform", $"\"Windows\""}, {$"Origin", $"https://webportal.jiit.ac.in:6011"}, {$"Sec-Fetch-Site", $"same-origin"}, {$"Sec-Fetch-Mode", $"cors"}, {$"Sec-Fetch-Dest", $"empty"}, {$"Referer", $"https://webportal.jiit.ac.in:6011/studentportal/"}, {$"Accept-Language", $"en-GB,en-US;q=0.9,en;q=0.8,hi;q=0.7"}, {$"Accept-Encoding", $"gzip, deflate"}}, TimeoutMilliseconds = 15000, HttpVersion = "1.1", CodePagesEncoding = "", AlwaysSendContent = false, DecodeHtml = false, UseCustomCipherSuites = false, CustomCipherSuites = new List<string>{"TLS_AES_128_GCM_SHA256", "TLS_CHACHA20_POLY1305_SHA256", "TLS_AES_256_GCM_SHA384", "TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256", "TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256", "TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256", "TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256", "TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384", "TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384", "TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA", "TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA", "TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA", "TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA", "TLS_RSA_WITH_AES_128_GCM_SHA256", "TLS_RSA_WITH_AES_256_GCM_SHA384", "TLS_RSA_WITH_AES_128_CBC_SHA", "TLS_RSA_WITH_AES_256_CBC_SHA", "TLS_RSA_WITH_3DES_EDE_CBC_SHA"}}).ConfigureAwait(false);

// BLOCK: Parse
data.ExecutingBlock("Parse");
List<string> SubjectList = MatchRegexGroupsRecursive(data, data.SOURCE.AsString(), "(?<=\"subjectcode\":)(?<one>.*?)(?=,)", "[0]", false, "", "", false);
data.LogVariableAssignment(nameof(SubjectList));
data.MarkForCapture(nameof(SubjectList));

