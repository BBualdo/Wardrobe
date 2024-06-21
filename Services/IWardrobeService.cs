using Wardrobe.BBualdo.Models;

namespace Wardrobe.BBualdo.Services;

public interface IWardrobeService
{
    List<Cloth> GetClothes();
    void AddCloth(Cloth cloth);
    void UpdateCloth(Cloth cloth);
    void DeleteCloth(Cloth cloth);
}