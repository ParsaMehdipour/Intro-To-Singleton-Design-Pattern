# Intro-To-Singleton-Design-Pattern
Singleton is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.

<p align="center">
  <img src="https://github.com/user-attachments/assets/5240ec10-f993-44db-ae83-62ded08dbdcb" width="800">
</p>

1. The Singleton class declares the static method getInstance that returns the same instance of its own class. The Singleton’s constructor should be hidden from the client code. Calling the getInstance method should be the only way of getting the Singleton object.
