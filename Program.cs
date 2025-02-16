using Html.Builders.Templates;
using Html.Components.Dividers;
using Html.EstruturasAuxiliares;

Div mainDiv = new();
DataHolderTable data = new() 
{
    Headers = Enumerable.Empty<string>().Append("Todo List").Append("Prioridade"),
    Values = Enumerable.Empty<object []>().
        Append(new object[2] { "Lavar a louça" , 1}).
        Append(new object[2] { "Estudar C# e F#", 3}).
        Append(new object[2] { "Atualizar meu currículo", 3}).
        Append(new object[2] { "Enviar meu currículo para empresas que me interessam", 3}).
        Append(new object[2] { "Trabalhar no meu portifólio", 5}),
    AutoFormatData = false
};

OutlookMailBodyTemplate template = new("", mainDiv, Enumerable.Empty<DataHolderTable>().Append(data));

Console.WriteLine(template.Build());
