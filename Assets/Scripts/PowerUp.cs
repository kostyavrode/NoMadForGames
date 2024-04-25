using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public enum Type
    {
        Coin,
        ExtraLife,
        MagicMushroom,
        Starpower,
    }

    public Type type;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            Collect(other.gameObject);
        }
    }

    private void Collect(GameObject player)
    {
        switch (type)
        {
            case Type.Coin:
                GayManager.Instance.AddCoin();
                break;

            case Type.ExtraLife:
                GayManager.Instance.AddLife();
                break;

            case Type.MagicMushroom:
                player.GetComponent<Gayer>().Grow();
                break;

            case Type.Starpower:
                player.GetComponent<Gayer>().Starpower();
                break;
        }

        Destroy(gameObject);
    }

}
