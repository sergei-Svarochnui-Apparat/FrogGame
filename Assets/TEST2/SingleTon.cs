using UnityEngine;

public class SingleTon : MonoBehaviour
{
    //Статическая ссылка на единсвтенный экземпляр
    public static SingleTon Instance { get; private set;}

    private void Awake()
    {
        // Если экземпляр уже существует и это не текущий объект — уничтожаем его
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else 
        Instance = this;
        DontDestroyOnLoad(gameObject);//Делаем неучтожаемым при загрузке новой сцены
    }
    // Пример метода синглтона
    public void StartGame()
    {
        print("Game Started!");
    }
}