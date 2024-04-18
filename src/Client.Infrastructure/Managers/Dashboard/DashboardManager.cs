﻿using SawsAppTemplate.Client.Infrastructure.Extensions;
using SawsAppTemplate.Shared.Wrapper;
using System.Net.Http;
using System.Threading.Tasks;
using SawsAppTemplate.Application.Features.Dashboards.Queries.GetData;

namespace SawsAppTemplate.Client.Infrastructure.Managers.Dashboard
{
    public class DashboardManager : IDashboardManager
    {
        private readonly HttpClient _httpClient;

        public DashboardManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<DashboardDataResponse>> GetDataAsync()
        {
            var response = await _httpClient.GetAsync(Routes.DashboardEndpoints.GetData);
            var data = await response.ToResult<DashboardDataResponse>();
            return data;
        }
    }
}