using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;

namespace HotelFinder.Business.Concrete;

public class HotelManager : IHotelService
{
    private readonly IHotelRepository _hotelRepository;
    
    public HotelManager(IHotelRepository hotelRepository)
    {
        _hotelRepository = hotelRepository;
    }
    
    public async Task<List<Hotel>> GetAllHotels()
    {
        return await _hotelRepository.GetAllHotels();
    }

    public async Task<Hotel> GetHotelById(int id)
    {
        if (id > 0)
        {
            return await _hotelRepository.GetHotelById(id);
        }

        throw new Exception("id can not be less than 1");
    }

    public async Task<Hotel> GetHotelByName(string name)
    {
        return await _hotelRepository.GetHotelByName(name);
    }

    public async Task<Hotel> GetHotelByIdAndName(int id, string name)
    {
        return await _hotelRepository.GetHotelByIdAndName(id, name);
    }

    public async Task<Hotel> CreateHotel(Hotel hotel)
    {
        return await _hotelRepository.CreateHotel(hotel);
    }

    public async Task<Hotel> UpdateHotel(Hotel hotel)
    {
        return await _hotelRepository.UpdateHotel(hotel);
    }

    public async Task DeleteHotel(int id)
    {
        await _hotelRepository.DeleteHotel(id);
    }
}