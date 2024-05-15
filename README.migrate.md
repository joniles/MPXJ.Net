# Migrating to MPXJ.Net

The original MPXJ Nuget packages provided varying degrees of .Net-ness on top
of the original Java library, so your migration route will very much depend
on which Nuget package you used.


## Migrating from net.sf.mpxj

The `net.sf.mpxj` [Nuget package](https://www.nuget.org/packages/net.sf.mpxj)
did not modify the original Java version of the library at all, so your
first step should probably be to use `Ikvm.Maven.Sdk` directly in your project
rather than using MPXJ.Net.

Remove the original MPXJ dependency from your project, and add the following:

```xml
<ItemGroup>
  <PackageReference Include="IKVM.Maven.Sdk" Version="1.6.9" />
</ItemGroup>

<ItemGroup>
    <MavenReference Include="net.sf.mpxj:mpxj" Version="12.10.20/>
</ItemGroup>
```

In theory everything should build without further changes to your code. Let me
know what you find is different and I'll update this section.

At this point your project should be working as before, it's only worth moving
to MPXJ.Net if you'd like to remove all traces of the original Java-ness of
MPXJ from your code.

## Migrating from net.sf.mpxj-for-csharp

The `net.sf.mpxj-for-csharp`
[Nuget package](https://www.nuget.org/packages/net.sf.mpxj-for-csharp)
attempted to make the translated version of MPXJ more .Net-like by replacing
getter and setter methods with properties, and renaming methods to use
initial caps to reflect typical C# style, although it wasn't possible to do
this everywhere in the code, and in many cases your code would be working
with the original Java types and data structures.

MPXJ.Net provides a complete C# wrapper around the translated MPXJ library -
no more Java type and data structures, all naming is consistent and so on. To
switch to MPXJ.Net, simply remove the reference to `net.sf.mpxj-for-csharp`
in your project and replace it with a reference to `MPXJ.Net`. The drawback
to this is that various identifiers will have changed, which means you'll need
to adjust your code accordingly.

To assist with this [a Powershell script](mpxj-net-convert.ps1) has been
provided which undertakes a find-and-replace approach on your code to deal
with the most common cases I came across when attempting this exercise
myself. This won't cover everything (happy to add more cases to the script if
you add any useful ones when working on your own code), and you will probably
need to make more manual changes to get everything compiling.

> IMPORTANT! Please ensure you back up your code before running the script!

## Migrating from net.sf.mpxj-for-vb

The `net.sf.mpxj-for-vb` [Nuget package](https://www.nuget.org/packages/net.sf.mpxj-for-vb)
contained a similar set of changes as provided by the
`net.sf.mpxj-for-csharp`, some changes were left out to accommodate VB's
rules on naming. I don't have any VB to try the conversion with but I suspect
that the conversion script described in the section above will be a helpful
first step. Let me know how you get on and I will update this section
accordingly!
