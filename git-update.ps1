param(
    [string]$mensagem = "Update $(Get-Date -Format 'dd/MM/yyyy HH:mm')"
)

Write-Host "Verificando alteracoes..." -ForegroundColor Cyan
git status --short

git add -A
git commit -m "$mensagem"
git push

Write-Host "Repositorio atualizado com sucesso!" -ForegroundColor Green