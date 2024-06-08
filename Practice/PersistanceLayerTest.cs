using System;
using System.Collections.Generic;

public class PersistenceLayerTest
{
    // 定義 Data Model
    public class DataModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // 其他屬性...
    }

    // 定義 Result Model
    public class ResultModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // 其他屬性...
    }

    // Persistence Layer (Repository Layer)
    public class PersistenceLayer
    {
        // 模擬資料庫
        private List<DataModel> database = new List<DataModel>
    {
        new DataModel { Id = 1, Name = "Item 1" },
        new DataModel { Id = 2, Name = "Item 2" },
        // 其他資料...
    };

        // 查詢資料庫並映射為 Data Model
        public DataModel GetDataModelById(int id)
        {
            return database.Find(item => item.Id == id);
        }
    }

    // Service Layer
    public class ServiceLayer
    {
        private PersistenceLayer persistenceLayer = new PersistenceLayer();

        // 將 Data Model 轉換為 Result Model
        public ResultModel ProcessData(int id)
        {
            DataModel dataModel = persistenceLayer.GetDataModelById(id);
            // 在這裡進行商業邏輯處理
            // 可能包括操作 Data Model，驗證資料等等
            // 在這個簡單的例子中，我們只是將 Data Model 轉換為 Result Model
            return new ResultModel { Id = dataModel.Id, Name = dataModel.Name };
        }
    }

    public void Run()
    {
        ServiceLayer service = new ServiceLayer();
        int idToQuery = 1;
        ResultModel result = service.ProcessData(idToQuery);
        Console.WriteLine($"Result: Id={result.Id}, Name={result.Name}");
    }
}

