using VehicleInfoApp.Models;

namespace VehicleInfoApp.Services.Interfaces;

public interface INhtsaApiService
{
    Task<List<MakeDto>> GetAllMakesAsync();
    Task<List<VehicleTypeDto>> GetVehicleTypesForMakeIdAsync(int makeId);
    Task<List<ModelDto>> GetModelsForMakeIdYearAsync(int makeId, int year);
}
