using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
namespace StarterAssets
{
    [RequireComponent(typeof(CharacterController))]
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
    [RequireComponent(typeof(PlayerInput))]
#endif
public class stamina_script : MonoBehaviour
{
	private float startStamina=100;
	public float currentStamina;
	private StarterAssetsInputs _input;
	public Slider sliderStamina;
    // Start is called before the first frame update
    void Start()
    {
        currentStamina=startStamina;
		_input = GetComponent<StarterAssetsInputs>();
    }
	

    // Update is called once per frame
    void Update()
    {
		if (!_input.sprint)
		{
			currentStamina += 0.08f;
		}
		sliderStamina.value = currentStamina;
		if (currentStamina >= 100){
			currentStamina=100;
		}
    }
	public void TakeStamina(float amount){
		currentStamina-=amount;
		sliderStamina.value = currentStamina;
	}
}
}
