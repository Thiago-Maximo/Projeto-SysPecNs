﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SysPecNSLib
{
    public class Categoria
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }



        public Categoria(int? id, string? nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        public Categoria(string? nome, string? sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
        public Categoria()
        {
         
        }
        public Categoria(int? id, string? nome)
        {
            Id = id;
            Nome = nome;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";
            cmd.Parameters.AddWithValue("spnome",Nome);
            cmd.Parameters.AddWithValue("spsigla",Sigla);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public  static Categoria ObterPorId(int? Id)
        {
            Categoria categoria = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from categorias where id = {Id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                categoria =new(dr.GetInt32(0),dr.GetString(1));
            }
            return categoria;
        }
        public static  List<Categoria> ObterLista()
        {
            List<Categoria> categorias = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from categorias";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                categorias.Add(new(dr.GetInt32(0), dr.GetString(1)));
            }
            return categorias;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update";
            cmd.Parameters.AddWithValue("spid",Id);
            cmd.Parameters.AddWithValue("spnome",Nome);
            cmd.Parameters.AddWithValue("spsigla",Sigla);
            cmd.ExecuteNonQuery();
        }
        public void Deletar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"Delete from categorias where id = {Id} ";
            cmd.ExecuteNonQuery();
        }
    }
}
