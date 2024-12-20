using HotelFinder.Entities;

namespace HotelFinder.Business.Abstract;

public interface IHotelService
{
    Task<List<Hotel>> GetAllHotels();
    Task<Hotel> GetHotelById(int id);
    Task<Hotel> GetHotelByName(string name);
    Task<Hotel> GetHotelByIdAndName(int id, string name);
    Task<Hotel> CreateHotel(Hotel hotel);
    Task<Hotel> UpdateHotel(Hotel hotel);
    Task DeleteHotel(int id);
}