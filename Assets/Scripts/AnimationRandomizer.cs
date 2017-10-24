using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationRandomizer : StateMachineBehaviour {
    public string m_parameterName = "idleAnimationID";
    public int[] m_stateIDAArray = { 0, 1 };


    // OnStateEnter is called before OnStateEnter is called on any state inside this state machine
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        //Debug.Log("entrou");
        if (m_stateIDAArray.Length <= 0)
        {
            animator.SetInteger(m_parameterName, 0);
        }
        else
        {
            //int index = Random.Range(0, m_stateIDAArray.Length);
            // Debug.Log(m_parameterName + "->" + m_stateIDAArray[index]);
            //animator.SetInteger(m_parameterName, m_stateIDAArray[index]);
            float i = Random.Range(0f, 1f); ;

            if (i > 0.75f)
            {
                animator.SetInteger(m_parameterName, 1);

            }
            else
            {
                animator.SetInteger(m_parameterName, 0);
            }

        }
    }

    // OnStateUpdate is called before OnStateUpdate is called on any state inside this state machine
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateExit is called before OnStateExit is called on any state inside this state machine
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateMove is called before OnStateMove is called on any state inside this state machine
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateIK is called before OnStateIK is called on any state inside this state machine
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateMachineEnter is called when entering a statemachine via its Entry Node
    //override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash){
    //
    //}

    // OnStateMachineExit is called when exiting a statemachine via its Exit Node
    //override public void OnStateMachineExit(Animator animator, int stateMachinePathHash) {
    //
    //}
}
