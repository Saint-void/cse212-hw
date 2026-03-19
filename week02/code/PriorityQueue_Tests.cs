using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities and remove highest priority
    // Expected Result: Item with highest priority is removed first
    // Defect(s) Found: Incorrect priority selection and item not removed from queue
    public void TestPriorityQueue_1()
    {
        var queue = new PriorityQueue();

        queue.Enqueue("A", 1);
        queue.Enqueue("B", 5);
        queue.Enqueue("C", 3);

        var result = queue.Dequeue();

        Assert.AreEqual("B", result);
    }

        [TestMethod]
    // Scenario: Add multiple items with same highest priority
    // Expected Result: First inserted item with highest priority is removed first
    // Defect(s) Found: FIFO order not maintained for equal priorities
    public void TestPriorityQueue_2()
    {
        var queue = new PriorityQueue();

        queue.Enqueue("A", 5);
        queue.Enqueue("B", 5);
        queue.Enqueue("C", 3);

        var result = queue.Dequeue();

        Assert.AreEqual("A", result);
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Attempt to dequeue from empty queue
    // Expected Result: InvalidOperationException thrown
    // Defect(s) Found: Exception not thrown or incorrect message
    public void TestPriorityQueue_Empty()
    {
        var queue = new PriorityQueue();

        try
        {
            queue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}