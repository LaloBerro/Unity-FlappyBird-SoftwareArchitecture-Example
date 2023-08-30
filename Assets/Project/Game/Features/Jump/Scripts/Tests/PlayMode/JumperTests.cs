using System.Collections;
using System.Collections.Generic;
using Jump.Domain;
using Jump.InterfaceAdapters;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class JumperTests
{
    //MethodName_WhatTheseConditions_DoesWhat().
    [Test]
    [TestCase(0)]
    public void Jump_WithForce0_ExpectReceived0(float force)
    {
        IForcer forcer = Substitute.For<IForcer>();
        Jumper jumper = new Jumper(forcer, force);
        jumper.Jump();

        forcer.Received().AddForce(force);
    }
    
    [UnityTest]
    public IEnumerator Jump_WithRigidbodyForcer_ChangePosition()
    {
        //Arrange
        GameObject rigidbodyForcerGameObject = new GameObject("RigidbodyForcer");

        rigidbodyForcerGameObject.AddComponent<CircleCollider2D>();
        Rigidbody2D rigidbody2D = rigidbodyForcerGameObject.AddComponent<Rigidbody2D>();
        RigidbodyForcer rigidbodyForcer = rigidbodyForcerGameObject.AddComponent<RigidbodyForcer>();
        rigidbodyForcer.SetRigidbody(rigidbody2D);

        GameObject floorGameObject = new GameObject("Floor");
        floorGameObject.AddComponent<BoxCollider2D>();
        floorGameObject.transform.position = new Vector3(0, -2, 0);
        
        yield return new WaitForSeconds(2f);

        Vector3 currentPosition = rigidbodyForcer.transform.position;

        IForcer forcer = rigidbodyForcer;
        
        Jumper jumper = new Jumper(forcer, 1000);
        
        //Act
        jumper.Jump();
        
        yield return new WaitForSeconds(1f);
        
        //Assert
        Assert.AreNotEqual(rigidbodyForcer.transform.position, currentPosition);
    }
}
