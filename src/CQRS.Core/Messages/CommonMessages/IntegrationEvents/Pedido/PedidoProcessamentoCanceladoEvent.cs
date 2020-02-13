﻿using CQRS.Core.DomainObjects.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Core.Messages.CommonMessages.IntegrationEvents.Pedido
{
    public class PedidoProcessamentoCanceladoEvent : IntegrationEvent
    {
        public Guid PedidoId { get; private set; }
        public Guid ClienteId { get; private set; }
        public ListaProdutosPedido ProdutosPedido { get; private set; }

        public PedidoProcessamentoCanceladoEvent(Guid pedidoId, Guid clienteId, ListaProdutosPedido produtosPedido)
        {
            AggregateId = pedidoId;
            PedidoId = pedidoId;
            ClienteId = clienteId;
            ProdutosPedido = produtosPedido;
        }
    }
}
