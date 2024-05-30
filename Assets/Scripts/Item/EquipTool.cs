using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class EquipTool : Equip
{

    public float attackRate;
    private bool attacking;
    public float attackDistance;

    [Header("Resource Gathering")]
    public bool doesGatherResources;

    [Header("Combat")]
    public bool doesDealDamage;
    public int damage;

    [Header("Utillity")]
    public float speedUp;
    public float durationTime;

    private Animator animator;
    private Camera camera;
    public PlayerController controller;

    //public GameObject effectObject;
    //private EffectIndicator effectIndicator;

    // Start is called before the first frame update
    void Start()
    {
        //effectIndicator = effectObject.GetComponent<EffectIndicator>();
        controller = CharacterManager.Instance.Player.GetComponent<PlayerController>();
        animator = GetComponent<Animator>();
        camera = Camera.main;
    }


    public override void OnAttackInput()
    {
        if(!attacking)
        {
            attacking = true;
            animator.SetTrigger("Attack");
            Invoke("OnCanAttack",attackRate);

            if(speedUp > 0)
            {
                controller.ChangeSpeed(speedUp, durationTime);
                //effectObject.SetActive(true);
                //effectIndicator.SkillOnEffect(durationTime);
            }
        }
    }

    void OnCanAttack()
    {
        attacking = false;
    }

    public void OnHit()
    {
        Ray ray = camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, attackDistance)) 
        {
            if(doesGatherResources&& hit.collider.TryGetComponent(out Resource resource))
            {
                resource.Gather(hit.point, hit.normal);
            }
        }
    }
}
