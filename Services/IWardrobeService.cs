using Wardrobe.BBualdo.Models;

namespace Wardrobe.BBualdo;

public interface IWardrobeService
{
    List<Cloth> GetClothes();
    void AddCloth(Cloth cloth);
    void UpdateCloth(Cloth cloth);
    void DeleteCloth(int id);
}