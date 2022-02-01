# My First Unit Tests

An exercise in using xUnit.

Based on [this tutorial](https://xunit.net/docs/getting-started/netcore/cmdline).

## To Run the Tests

```bash
dotnet test
```

You can use the output messages to figure out when various objects are created.

![raw sequence diagram](xUnit_fixtures_sequence_diagram.png)

The parallel execution of unit tests can be confusing.  Here is a cleaned up
version.

![cleaned up sequence diagram](xUnit_fixtures_cleaned_up_sequence_diagram.png)

This other version, drawn with [`sdedit`](http://sdedit.sourceforge.net/),
highlights the lifelines a little better.

![sdedit sequence diagram](xUnit_fixtures_cleaned_up_sequence_diagram.sdedit.png)
