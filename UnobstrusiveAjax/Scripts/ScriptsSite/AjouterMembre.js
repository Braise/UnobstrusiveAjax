function AfficherFormulaireAJoutMembre(idIcone, idFormulaire)
{
    var icone = document.getElementById(idIcone);
    var formulaire = document.getElementById(idFormulaire);

    icone.style.display = "none";
    formulaire.style.display = "block";
}