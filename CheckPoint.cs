using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    // check if point active
    public bool activated = false;

    public static GameObject[] CheckPointsList;

    void Start()
    {
        //Search check points in current area

        CheckPointsList = GameObject.FindGameObjectWithTag("CheckPoint");
    }

    private void ActivateCheckPoint()
    {
        foreach (GameObject cp in CheckPointsList)
        {
            cp.GetComponent().activated = false;
            cp.GetComponent().SetBool("Active",false);
        }

        activated = true;
    }

    void OnTriggerenter(Collider other)
    {
        if (other.tag == "Player")
        {
            ActivateCheckPoint();
        }
    }

    public static Vector 3 GetActiveCheckPointPosition()
    {
        //This sets plater to default pos if not checkpoint will probaly replace with restart scene code
        Vector3 result = new Vector3(0, 0, 0);
        if(CheckPointsList != null)
        {
            foreach(GameObject cp in CheckPointsList)
            {
                if (cp.GetComponent().activated)
                {
                    result = cp.transform.position;
                    break;
                }
            }
        }
        return restart;
    }
}