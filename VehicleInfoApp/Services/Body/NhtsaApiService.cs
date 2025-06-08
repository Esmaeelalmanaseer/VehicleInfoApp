using VehicleInfoApp.Models;
using VehicleInfoApp.Services.Interfaces;

namespace VehicleInfoApp.Services.Body;

public class NhtsaApiService : INhtsaApiService
{
    private readonly HttpClient _http;

    public NhtsaApiService(HttpClient http)
    {
        _http = http;
    }
    public async Task<List<MakeDto>> GetAllMakesAsync()
    {
        var url = "https://vpic.nhtsa.dot.gov/api/vehicles/getallmakes?format=json";
        NhtsaResponse<MakeDto>? result = await _http.GetFromJsonAsync<NhtsaResponse<MakeDto>>(url);
        return result?.Results ?? new();
    }

    public async Task<List<VehicleTypeDto>> GetVehicleTypesForMakeIdAsync(int makeId)
    {
        string? url = $"https://vpic.nhtsa.dot.gov/api/vehicles/GetVehicleTypesForMakeId/{makeId}?format=json";
        NhtsaResponse<VehicleTypeDto>? result = await _http.GetFromJsonAsync<NhtsaResponse<VehicleTypeDto>>(url);
        return result?.Results ?? new();
    }

    public async Task<List<ModelDto>> GetModelsForMakeIdYearAsync(int makeId, int year)
    {
        string? url = $"https://vpic.nhtsa.dot.gov/api/vehicles/GetModelsForMakeIdYear/makeId/{makeId}/modelyear/{year}?format=json";
        NhtsaResponse<ModelDto>? result = await _http.GetFromJsonAsync<NhtsaResponse<ModelDto>>(url);
        return result?.Results ?? new();
    }
}