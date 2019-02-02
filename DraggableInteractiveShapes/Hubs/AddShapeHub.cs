using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using DraggableInteractiveDivs.Models;
using Microsoft.AspNet.SignalR;

namespace DraggableInteractiveDivs.Hubs
{
    public class AddShapeHub : Hub
    {
        static ConcurrentDictionary<string, ShapeModel> shapesDictionary =
            new ConcurrentDictionary<string, ShapeModel>();

        public void FirstHandShake()
        {
            Parallel.ForEach(shapesDictionary, (movingShape) =>
            {                
                Clients.Caller.newShapeAdded(movingShape.Value);
            });
        }     

        public void AddNewShape(ShapeModel shapeModel)
        {
            shapesDictionary[shapeModel.Id] = shapeModel;
            Clients.Others.newShapeAdded(shapeModel);
        }
    }
}