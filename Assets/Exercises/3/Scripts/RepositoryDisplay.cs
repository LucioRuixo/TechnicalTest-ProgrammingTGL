using TMPro;
using UnityEngine;

// Lo siento si esto no es lo que pedían en este ejercicio, pero la verdad que no me quedó del todo clara la consigna.
namespace Project.Exercise3
{
    public class RepositoryDisplay : MonoBehaviour
    {
        [Header("Repositories")]
        [SerializeField] LifeLocalRepository lifeLocalRepository;
        [SerializeField] NameLocalRepository nameLocalRepository;

        [Header("Texts")]
        [SerializeField] TMP_Text lifeText;
        [SerializeField] TMP_Text nameText;

        float _life;
        string _name;

        void Update()
        {
            float newLife = lifeLocalRepository.GetData().Result;
            if (newLife != _life) DisplayData(newLife, lifeText);

            string newName = nameLocalRepository.GetData().Result;
            if (newName != _name) DisplayData(newName, nameText);
        }

        void DisplayData<Data>(Data data, TMP_Text text)
        {
            Debug.Log(data);
            text.text = data.ToString();
        }
    }
}