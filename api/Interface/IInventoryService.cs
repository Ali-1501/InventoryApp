
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Interface;

public interface IInventoryService{
public ApiResponse GetDashboardData();
public ApiResponse GetAllPurchase();
public ApiResponse GetAllSale();
public ApiResponse GetAllProducts();
public ApiResponse GetAllStock();

public ApiResponse CreateNewPurchase(Purchase obj);
public ApiResponse CreateNewSale(Sale obj);
public void CreateNewProduct();
public void CheckStockByProductId(int ID);
}