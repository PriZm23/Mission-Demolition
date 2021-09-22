using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public static GameObject POI; // Ссылка на интересующий объект
    [Header("Set Dynamically")]
    public float camZ; // Желаемая координата Z камеры
    void Awake()
    {
        camZ = this.transform.position.z;
    }
    void FixedUpdate()
    {
        // Однострочная версия if не требует фигурных скобок
        if (POI == null) return; // Выйти если нет интересующего объекта

        // Получить позицию интересующего объекта
        Vector3 destination = POI.transform.position;

        // Принудительно установить значение destination.z равным camZ, чтобы
        // отодвинуть камеру подальше
        destination.z = camZ;

        // Поместить камеру в позицию destination
        transform.position = destination;
    }
}
