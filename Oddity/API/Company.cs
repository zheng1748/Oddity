﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Oddity.API.Builders;
using Oddity.API.Builders.Company;
using Oddity.API.Models;
using Oddity.API.Models.Company;

namespace Oddity.API
{
    public class Company
    {
        private HttpClient _httpClient;

        public Company(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public InfoBuilder GetInfo()
        {
            return new InfoBuilder(_httpClient);
        }

        public HistoryBuilder GetHistory()
        {
            return new HistoryBuilder(_httpClient);
        }
    }
}
