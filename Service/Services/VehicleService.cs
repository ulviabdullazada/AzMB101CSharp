using Core.Models;
using Microsoft.VisualBasic;

namespace Service.Services;

public class VehicleService
{
    public Vehicle[] _arr = new Vehicle[0];
    public bool AddCar(Car car)
    {
        if (car.WinCode == null)
        {
            Console.WriteLine("Wincode null ola bilmez!");
            return false;
        }
        Add(car);
        return true;
    }
    public void AddPlane(Plane plane)
    {
        Add(plane);
    }
    private void Add(Vehicle vehicle)
    {
        Array.Resize(ref _arr, _arr.Length + 1);
        _arr[_arr.Length - 1] = vehicle;
    }
    public void RemoveAt(int index)
    {
        if (index < 0 || index > _arr.Length - 1) return;
        Vehicle[] newArr = new Vehicle[_arr.Length - 1];
        for (int i = 0; i < index; i++)
        {
            newArr[i] = _arr[i];
        }
        for (int i = index+1;i < _arr.Length;i++) 
        {
            newArr[i-1] = _arr[i];
        }
        _arr = newArr;
    }
}
