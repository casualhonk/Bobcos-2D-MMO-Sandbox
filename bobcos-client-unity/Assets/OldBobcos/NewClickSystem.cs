using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewClickSystem : MonoBehaviour
{
    public bool boolvalu1 = true;

    public void Update()
    {
        if(Input.GetMouseButtonUp(0) && !UICLICK.IsBusy)
        {
            boolvalu1 = true;
        }

        if (Input.GetMouseButton(0) && boolvalu1 && !UICLICK.IsBusy)
        {
            boolvalu1 = false;



            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            try
            {
                TileScript t = hit.transform.gameObject.GetComponent<TileScript>();



                ClientSend.SendBlock((short)t.siraid);
            }
            catch
            {

            }


        }
    }
    public void Start()
    {
   
    }

        IEnumerator Waiter()
        {
            while (true)
            {
                if (Input.GetMouseButton(0))
                {
                    boolvalu1 = true;



                    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


                    Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

                    RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

                    try
                    {
                        TileScript t = hit.transform.gameObject.GetComponent<TileScript>();



                        ClientSend.SendBlock((short)t.siraid);
                    }
                    catch
                    {

                    }


                }
                
                yield return new WaitForSeconds(0.20f);

            }
        }


    }


   

