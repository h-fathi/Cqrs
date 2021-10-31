# Cqrs
Here is an implementation of CQRS with MediatR in ASP.NET Core 3.1

### MediatR Pipeline Behaviour in ASP.NET Core – Logging and Validation

Summary
CQRS, Command Query Responsibility Segregation is a design pattern that separates the read and write operations of a data source. Here Command refers to a Database Command, which can be either an Insert / Update or Delete Operation, whereas Query stands for Querying data from a source. It essentially separates the concerns in terms of reading and writing, which makes quite a lot of sense.
