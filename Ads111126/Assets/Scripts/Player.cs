using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed;
        

    void Update()
    {
        Vector2 move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;
        transform.Translate(move);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ads")
        {
            // GameObject.Find("AdsInitializer").GetComponent<AdsInitializer>().LoadInterstitialAd();
            // GameObject.Find("AdsInitializer").GetComponent<AdsInitializer>().ShowInterstitialAd();
            GameObject.Find("AdsInitializer").GetComponent<AdsInitializer>().LoadRewardedAd();
            GameObject.Find("AdsInitializer").GetComponent<AdsInitializer>().ShowRewardedAd();
        }
    }
}
