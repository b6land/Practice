using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

public class ConcurrentPractice
{
    public void Run()
    {
        // 建立一個 ConcurrentBag 來存放字串
        ConcurrentBag<string> bag = new ConcurrentBag<string>();

        // 啟動多個 Task 來新增和移除項目
        Task[] tasks = new Task[3];

        // 增加項目的 Task
        for (int i = 0; i < tasks.Length; i++)
        {
            int taskNum = i; 
            tasks[i] = Task.Run(() =>
            {
                for (int j = 0; j < 50000; j++)
                {
                    string item = $"Task {taskNum} - Item {j}";
                    bag.Add(item);
                }
            });
        }

        // 移除項目的 Task
        for (int i = 0; i < tasks.Length; i++)
        {
            tasks[i] = Task.Run(() =>
            {
                string item;
                while (!bag.IsEmpty)
                {
                    bag.TryTake(out item);
                }
            });
        }

        // 等待所有 Task 完成
        Task.WaitAll(tasks);
    }

    public void Run2()
    {
        // 改成用一般 List 來存放字串
        List<string> list = new List<string>();

        // 啟動多個 Task 來新增和移除項目
        Task[] tasks = new Task[3];

        // 增加項目的 Task
        for (int i = 0; i < tasks.Length; i++)
        {
            int taskNum = i; 
            tasks[i] = Task.Run(() =>
            {
                for (int j = 0; j < 50000; j++)
                {
                    string item = $"Task {taskNum} - Item {j}";
                    list.Add(item);
                }
            });
        }

        // 移除項目的 Task
        for (int i = 0; i < tasks.Length; i++)
        {
            tasks[i] = Task.Run(() =>
            {
                string item;
                while (list.Count > 0)
                {
                    // 這裡可能會有 Race Condition
                    item = list[0];
                    list.RemoveAt(0);
                }
            });
        }

        // 等待所有 Task 完成
        Task.WaitAll(tasks);
    }
}
