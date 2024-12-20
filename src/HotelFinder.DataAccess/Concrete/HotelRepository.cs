using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelFinder.DataAccess.Concrete;

public class HotelRepository : IHotelRepository
{
    public async Task<List<Hotel>> GetAllHotels()
    {
        using (var HotelDbContext = new HotelDbContext())
        {
            return await HotelDbContext.Hotels.ToListAsync();
        }
    }

    public async Task<Hotel> GetHotelById(int id)
    {
        using (var HotelDbContext = new HotelDbContext())
        {
            return await HotelDbContext.Hotels.FindAsync(id);
        }
    }

    public async Task<Hotel> GetHotelByName(string name)
    {
        using (var HotelDbContext = new HotelDbContext())
        {
            return await HotelDbContext.Hotels.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());
        }
    }

    public async Task<Hotel> GetHotelByIdAndName(int id, string name)
    {
        using (var HotelDbContext = new HotelDbContext())
        {
            return HotelDbContext.Hotels.FirstOrDefault(x => x.Id == id && x.Name.ToLower() == name.ToLower());
        }
    }

    public async Task<Hotel> CreateHotel(Hotel hotel)
    {
        using (var HotelDbContext = new HotelDbContext())
        {
            HotelDbContext.Hotels.AddAsync(hotel);
            await HotelDbContext.SaveChangesAsync();
            return hotel;
        }
    }

    public async Task<Hotel> UpdateHotel(Hotel hotel)
    {
        using (var HotelDbContext = new HotelDbContext())
        {
            HotelDbContext.Hotels.Update(hotel);
            await HotelDbContext.SaveChangesAsync();
            return hotel;
        }
    }

    public async Task DeleteHotel(int id)
    {
        using (var HotelDbContext = new HotelDbContext())
        {
            var deletedHotel = await GetHotelById(id);
            HotelDbContext.Hotels.Remove(deletedHotel);
            await HotelDbContext.SaveChangesAsync();
        }
    }
}