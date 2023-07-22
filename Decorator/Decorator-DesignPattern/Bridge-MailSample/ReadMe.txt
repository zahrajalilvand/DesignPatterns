Bridge Tips
	1.We can join Implementor and ConcreteImplementor to make it simple but it is not ideal
	2.Use Internal Midifier
	3.it's look like Strategy Design
	4.Methods in Implementor and Abstraction shouldn't be as same
	5.We can implement many Implementor for an Abstraction
	6.Bridge design usually is used in combination with IOC or Dependency Injection methods
	7. Abstraction is look like facade design

Bridge Advantages
	1.Weak Connection
	2.Open Close Principle has to observe
	3.Simple Responsibility Principle has to observe
	4.Seperation of Concerne has to observe
	5.Abstraction and Implementor can develop independent
	6.prevent from additional compile, you can use and copy the bridge design dll to server
	7.Bridge design helps to layer code and make it clean

Bridge Disadvantages
	1.If you change the interface, all the codes will be damaged

When to use?
	1.In runtime 
	2.develop Abstraction independent
	3.Changing implementation without change in abstraction and client
	4.Developing the impelmentations don't need client codes compile again
	5.Weak connection for implementation and abstraction
	6.Adding new implementation with saving implementation

DI or Bridg?
	If you are using DI, it's more better but if you don't have DI and want to change in runtime Bridge is a solution.