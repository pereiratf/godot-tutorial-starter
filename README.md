# Projeto base deste módulo

Baixe e abra o projeto base antes de continuar. Ele contém:

- **`Player.tscn`** — o personagem do jogo (`CharacterBody2D` + `AnimatedSprite2D` + `CollisionShape2D`), já com o script `Player.cs` anexado. O script traz um esqueleto inicial (`_Ready` e `_Process`) que você vai completar ao longo do módulo.
- **`mapa_1.tscn`** — um cenário básico montado com `TileMapLayer`, já com o Player posicionado para testes.

Os nós `AnimatedSprite2D` (animações) e `TileMapLayer` (construção do cenário) já estão configurados aqui, mas só serão explicados em detalhe no módulo seguinte.
