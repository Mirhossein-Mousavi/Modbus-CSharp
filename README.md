### ModBus Library

* Modbas is one of the safest 🔒 and most popular 👨‍👩‍👦 industrial protocols 🛠. This protocol has two modes of slave and master. In Modbas, access to memory cells ⬜ is possible through the address of the registry

* Master: In this mode, the other slaves are summoned and sent orders. The summoned slave reacts to the command when it receives it, thus forming a connection between several devices. Slaves each have a parameter to identify called a slaveID.

### Functions :

```csharp
bool WriteRegister_Request(byte SlaveId, int StartAddress, int[] Data) {...}

List<int> ReadRegister_Request(byte SlaveId, int StartAddress, int Count) {...}
```

### Example of a project done with this library :