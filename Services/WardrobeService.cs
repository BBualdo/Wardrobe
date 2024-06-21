using Wardrobe.BBualdo.Models;

namespace Wardrobe.BBualdo.Services;

public class WardrobeService:IWardrobeService
{
    private List<Cloth> _clothes =
    [
        new Cloth
        {
            Id = 1,
            Name = "T-Shirt",
            Category = "Top",
            Brand = "Police",
            Color = "Dark Blue",
            Size = "M",
            ImagePath = "/images/t-shirt.jpg"
        },
        new Cloth
        {
            Id = 2,
            Name = "Hoodie",
            Category = "Top",
            Brand = "Premiere",
            Color = "Black",
            Size = "L",
            ImagePath = "/images/hoodie.jpg"
        },
        new Cloth
        {
            Id = 3,
            Name = "Jacket",
            Category = "Top",
            Brand = "Premiere",
            Color = "Black",
            Size = "L",
            ImagePath = "/images/jacket.jpg"
        },
        new Cloth
        {
            Id = 4,
            Name = "Shorts",
            Category = "Pants",
            Brand = "MSBHV",
            Color = "Grey",
            Size = "S",
            ImagePath = "/images/shorts.jpg"
        },
        new Cloth
        {
            Id = 5,
            Name = "Cap",
            Category = "Accessories",
            Brand = "MSBHV",
            Color = "Light Grey",
            Size = "Unisex",
            ImagePath = "/images/cap.jpg"
        }
    ];

    public List<Cloth> GetClothes()
    {
        return _clothes;
    }

    public void AddCloth(Cloth cloth)
    {
        _clothes.Add(cloth);
    }

    public void UpdateCloth(Cloth cloth)
    {
        var index = _clothes.FindIndex(c => c.Id == cloth.Id);
        if (index != -1) _clothes[index] = cloth;
    }

    public void DeleteCloth(Cloth cloth)
    {
        var clothToRemove = _clothes.First(c => c.Id == cloth.Id);
        _clothes.Remove(clothToRemove);
    }
}