using UnityEngine;

public class Shelter : MonoBehaviour
{
    [SerializeField]
    private int maxResistance = 3;

    public int MaxResistance
    {
        get
        {
            return maxResistance;
        }
        protected set
        {
            maxResistance = value;
        }
    }

    /*public void Damage(int damage)
    {
        damage = 1;

    }*/

    protected void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Hazard>() != null)
        {
            

            maxResistance = -1;

            if (maxResistance == 0)
            {
                OnShelterDestroy();
            }
        }
    }

    private void OnShelterDestroy()
    {
        Destroy(this.gameObject);

    }
}