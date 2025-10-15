using UnityEngine;
using UnityEngine.UI;
public class HPBAR : MonoBehaviour
{
    public Health health;
    public Image hpFill;



    private void Start()
    {
        
    }


    private void Update()
    {
        hpFill.fillAmount = health.currentHealth / health.maxHealth;
    }
}
