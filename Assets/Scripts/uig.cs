using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
using UnityEngine.InputSystem;
#endif
namespace StarterAssets
{
    public class uig : MonoBehaviour
    {
        public GameObject ssa;
        StarterAssetsInputs sai;
        // Start is called before the first frame update

        void OnTriggerEnter(Collider other)
        {
            ssa.SetActive(true);    
        }

        void OnTriggerExit()
        {
            ssa.SetActive(false);

        }
    }
}