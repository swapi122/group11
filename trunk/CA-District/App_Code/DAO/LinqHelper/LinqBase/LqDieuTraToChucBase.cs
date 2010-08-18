




/*
'===============================================================================
'  LinqHelper.DAO.DieuTraToChucBase
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqDieuTraToChucBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDieuTraToChucBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqDieuTraToChucEntity obj)
		{
			provider.GetTable<LqDieuTraToChucEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqDieuTraToChucEntity _obj)
		{
			var q = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqDieuTraToChucEntity tmp = q.First<LqDieuTraToChucEntity>();
			
			tmp.IdToChuc = _obj.IdToChuc;
			tmp.NgayTienHanh = _obj.NgayTienHanh;
			tmp.NoiDungDieuTra = _obj.NoiDungDieuTra;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.MaTp = _obj.MaTp;
			tmp.GhiChu = _obj.GhiChu;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqDieuTraToChucEntity obj)
		{
			provider.GetTable<LqDieuTraToChucEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqDieuTraToChucEntity ob = (LqDieuTraToChucEntity)q.First<LqDieuTraToChucEntity>();
            provider.GetTable<LqDieuTraToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdToChuc(Guid IdToChuc)
		{
			var q = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                    where obj.IdToChuc == IdToChuc
                    select obj;
					
            LqDieuTraToChucEntity ob = (LqDieuTraToChucEntity)q.First<LqDieuTraToChucEntity>();
            provider.GetTable<LqDieuTraToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTienHanh(DateTime NgayTienHanh)
		{
			var q = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                    where obj.NgayTienHanh.Value == NgayTienHanh
                    select obj;
					
            LqDieuTraToChucEntity ob = (LqDieuTraToChucEntity)q.First<LqDieuTraToChucEntity>();
            provider.GetTable<LqDieuTraToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNoiDungDieuTra(string NoiDungDieuTra)
		{
			var q = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                    where obj.NoiDungDieuTra == NoiDungDieuTra
                    select obj;
					
            LqDieuTraToChucEntity ob = (LqDieuTraToChucEntity)q.First<LqDieuTraToChucEntity>();
            provider.GetTable<LqDieuTraToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqDieuTraToChucEntity ob = (LqDieuTraToChucEntity)q.First<LqDieuTraToChucEntity>();
            provider.GetTable<LqDieuTraToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqDieuTraToChucEntity ob = (LqDieuTraToChucEntity)q.First<LqDieuTraToChucEntity>();
            provider.GetTable<LqDieuTraToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqDieuTraToChucEntity ob = (LqDieuTraToChucEntity)q.First<LqDieuTraToChucEntity>();
            provider.GetTable<LqDieuTraToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqDieuTraToChucEntity ob = (LqDieuTraToChucEntity)q.First<LqDieuTraToChucEntity>();
            provider.GetTable<LqDieuTraToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqDieuTraToChucEntity ob = (LqDieuTraToChucEntity)q.First<LqDieuTraToChucEntity>();
            provider.GetTable<LqDieuTraToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqDieuTraToChucEntity ob = (LqDieuTraToChucEntity)q.First<LqDieuTraToChucEntity>();
            provider.GetTable<LqDieuTraToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqDieuTraToChucEntity ob = (LqDieuTraToChucEntity)q.First<LqDieuTraToChucEntity>();
            provider.GetTable<LqDieuTraToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqDieuTraToChucEntity ob = (LqDieuTraToChucEntity)q.First<LqDieuTraToChucEntity>();
            provider.GetTable<LqDieuTraToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqDieuTraToChucEntity ob = (LqDieuTraToChucEntity)q.First<LqDieuTraToChucEntity>();
            provider.GetTable<LqDieuTraToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqDieuTraToChucEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqDieuTraToChucEntity>();
		}

		public List<LqDieuTraToChucEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                        select obj;
            return query.ToList<LqDieuTraToChucEntity>();
		}
		
		
		public List<LqDieuTraToChucEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqDieuTraToChucEntity>();
		}
		
		
		public List<LqDieuTraToChucEntity> SelectByIdToChuc(Guid IdToChuc)
		{
			var query = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                        where obj.IdToChuc == IdToChuc
                        select obj;
            return query.ToList<LqDieuTraToChucEntity>();
		}
		
		
		public List<LqDieuTraToChucEntity> SelectByNgayTienHanh(DateTime NgayTienHanh)
		{
			var query = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                        where obj.NgayTienHanh.Value == NgayTienHanh
                        select obj;
            return query.ToList<LqDieuTraToChucEntity>();
		}
		
		
		public List<LqDieuTraToChucEntity> SelectByNoiDungDieuTra(string NoiDungDieuTra)
		{
			var query = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                        where obj.NoiDungDieuTra == NoiDungDieuTra
                        select obj;
            return query.ToList<LqDieuTraToChucEntity>();
		}
		
		
		public List<LqDieuTraToChucEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqDieuTraToChucEntity>();
		}
		
		
		public List<LqDieuTraToChucEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqDieuTraToChucEntity>();
		}
		
		
		public List<LqDieuTraToChucEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqDieuTraToChucEntity>();
		}
		
		
		public List<LqDieuTraToChucEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqDieuTraToChucEntity>();
		}
		
		
		public List<LqDieuTraToChucEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqDieuTraToChucEntity>();
		}
		
		
		public List<LqDieuTraToChucEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqDieuTraToChucEntity>();
		}
		
		
		public List<LqDieuTraToChucEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqDieuTraToChucEntity>();
		}
		
		
		public List<LqDieuTraToChucEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqDieuTraToChucEntity>();
		}
		
		
		public List<LqDieuTraToChucEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqDieuTraToChucEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqDieuTraToChucEntity>();
		}
		
		
		

	}
}
