using UnityEngine;
using UnityEngine.UI;
public class HPBAR : MonoBehaviour
{
    public Health health;
    public Image hpFill;



    void Start()
    {
        
    }


    void Update()
    {
        hpFill.fillAmount = health.currentHealth / health.maxHealth;
    }
}
