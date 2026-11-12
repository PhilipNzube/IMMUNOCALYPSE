using UnityEngine.UI;
using UnityEngine.Purchasing;
using UnityEngine;

public class MyInAppPurchaseScript : MonoBehaviour
{
    public string Coins5000;
    public string Coins15000;
    public string Coins50000;

    public string Gems500;
    public string Gems1500;
    public string Gems5000;

    public GameObject PurchaseErrorMessage;
    public Text PurchaseErrorText;
    public GameObject PurchaseMessage;
    public Text PurchaseText;
    public int CoinValue;
    public int GemValue;

    public void OnPurchaseComplete(Product product)
    {
        if (product.definition.id == Coins5000)
        {
            CoinValue = 5000;
            PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") + CoinValue);
            PurchaseMessage.gameObject.SetActive(true);
            PurchaseText.text = "Purchase Of 5000 Coins Was Successful";
            Debug.Log("Purchase Of 5000 Coins Was Successful");
        }

        if (product.definition.id == Coins15000)
        {
            CoinValue = 15000;
            PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") + CoinValue);
            PurchaseMessage.gameObject.SetActive(true);
            PurchaseText.text = "Purchase Of 15000 Coins Was Successful";
            Debug.Log("Purchase Of 15000 Coins Was Successful");
        }

        if (product.definition.id == Coins50000)
        {
            CoinValue = 50000;
            PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") + CoinValue);
            PurchaseMessage.gameObject.SetActive(true);
            PurchaseText.text = "Purchase Of 50000 Coins Was Successful";
            Debug.Log("Purchase Of 50000 Coins Was Successful");
        }

        if (product.definition.id == Gems500)
        {
            GemValue = 500;
            PlayerPrefs.SetInt("GemValue", PlayerPrefs.GetInt("GemValue") + GemValue);
            PurchaseMessage.gameObject.SetActive(true);
            PurchaseText.text = "Purchase Of 500 Gems Was Successful";
            Debug.Log("Purchase Of 500 Gems Was Successful");
        }

        if (product.definition.id == Gems1500)
        {
            GemValue = 1500;
            PlayerPrefs.SetInt("GemValue", PlayerPrefs.GetInt("GemValue") + GemValue);
            PurchaseMessage.gameObject.SetActive(true);
            PurchaseText.text = "Purchase Of 1500 Gems Was Successful";
            Debug.Log("Purchase Of 1500 Gems Was Successful");
        }

        if (product.definition.id == Gems5000)
        {
            GemValue = 5000;
            PlayerPrefs.SetInt("GemValue", PlayerPrefs.GetInt("GemValue") + GemValue);
            PurchaseMessage.gameObject.SetActive(true);
            PurchaseText.text = "Purchase Of 5000 Gems Was Successful";
            Debug.Log("Purchase Of 5000 Gems Was Successful");
        }
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason reason)
    {
        PurchaseErrorMessage.gameObject.SetActive(true);
        PurchaseErrorText.text = "Purchase Of " + product.definition.id + " Failed Due To " + reason;
        Debug.Log("Purchase Of " + product.definition.id + " Failed Due To " + reason);
    }

    public void ClosePurchaseSuccessMessage()
    {
        PurchaseMessage.gameObject.SetActive(false);
    }

    public void ClosePurchaseErrorMessage()
    {
        PurchaseErrorMessage.gameObject.SetActive(false);
    }
}
