﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using DraggableInteractiveDivs.Models;
using Microsoft.AspNet.SignalR;

namespace DraggableInteractiveDivs.Hubs
{
    public class MoveShapeHub : Hub
    {
        static ConcurrentDictionary<string, ShapeModel> movingShapesDictionary =
            new ConcurrentDictionary<string, ShapeModel>();

        public void FirstHandShake()
        {
            Parallel.ForEach(movingShapesDictionary, (movingShape) =>
            {
                Clients.Caller.updateShape(movingShape.Value);
            });
        }

        public void UpdateShapePostion(ShapeModel shapeModel)
        {
            movingShapesDictionary[shapeModel.Id] = shapeModel;
            Clients.Others.updateShape(shapeModel);
        }        
    }
}