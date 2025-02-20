using Html.Builders.Templates;
using Html.Components.Dividers;
using Html.EstruturasAuxiliares;

Div mainDiv = new();
DataHolderTable data = new() 
{
    Headers = ["Todo List", "Prioridade"],
    Values = [
        ["Lavar a louça" , 1],
        ["Estudar C# e F#", 3],
        ["Atualizar meu currículo", 3],
        ["Enviar meu currículo para empresas que me interessam", 3],
        ["Trabalhar no meu portfólio", 5],
    ],
    AutoFormatData = false
};

OutlookMailBodyTemplate template = new("", mainDiv, [data]);

Console.WriteLine(template.Build());
