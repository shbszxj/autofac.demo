﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DesignPattern.Structural.Composite.Neuron
{
    public class NeuronNetwork : IDesignPatternDemo
    {
        public string Title => "8.2";

        public string Description => "Composite - Neuron";

        public void Run()
        {
            var neuron1 = new Neuron();
            var neuron2 = new Neuron();
            var layer1 = new NeuronLayer();
            var layer2 = new NeuronLayer();

            neuron1.ConnectTo(neuron2);
            neuron1.ConnectTo(layer1);
            layer1.ConnectTo(layer2);
        }
    }

    public class Neuron : IEnumerable<Neuron>
    {
        public float Value;
        private Lazy<List<Neuron>> _in = new Lazy<List<Neuron>>(() => new List<Neuron>());
        private Lazy<List<Neuron>> _out = new Lazy<List<Neuron>>(() => new List<Neuron>());

        public List<Neuron> In => _in.Value;
        public List<Neuron> Out => _out.Value;

        public IEnumerator<Neuron> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return this;
        }
    }

    public class NeuronLayer : Collection<Neuron>
    {

    }

    public static class ExtensionMethods
    {
        public static void ConnectTo(this IEnumerable<Neuron> self, IEnumerable<Neuron> other)
        {
            if (ReferenceEquals(self, other)) return;

            foreach (var from in self)
            {
                foreach (var to in other)
                {
                    from.Out.Add(to);
                    to.In.Add(from);
                }
            }
        }
    }
}
