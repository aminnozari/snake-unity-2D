using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snake : MonoBehaviour
{
    public GameObject Apple;
 public GameObject WallRight;
  public GameObject WallTop;
   public GameObject WallBottom;
    public GameObject WallLeft; 
    public Vector2 direction = new Vector2(0, 0);
    public float speed = 100;
    // Start is called before the first frame update
    void Start()
    {
        int x = (int) Random.Range(WallLeft.transform.position.x, WallRight.transform.position.x); 
         int y = (int) Random.Range(WallTop.transform.position.y, WallBottom.transform.position.y); Instantiate(Apple, new Vector2(x, y), transform.rotation ); 
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.UpArrow)) 
           direction = Vector2.up; 
           else if(Input.GetKey(KeyCode.DownArrow))
            direction = - Vector2.up;
             else if(Input.GetKey(KeyCode.RightArrow))
              direction = Vector2.right; 
              else if(Input.GetKey(KeyCode.LeftArrow))
               direction = - Vector2.right; 
               GetComponent<Rigidbody2D>().velocity = direction * speed;
                } 
                void OnCollisionEnter2D(Collision2D target) 
                { Destroy(target.gameObject); 
                int x = (int) Random.Range(WallLeft.transform.position.x, WallRight.transform.position.x); 
                int y = (int) Random.Range(WallTop.transform.position.y, WallBottom.transform.position.y); 
                Instantiate(Apple,  new Vector2(x, y),
                 transform.rotation  ); 
                 Debug.Log("Ummmm! bah bah!"); 
                 }
        
    
}
