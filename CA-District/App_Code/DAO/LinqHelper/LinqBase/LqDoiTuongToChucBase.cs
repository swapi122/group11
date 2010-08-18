




/*
'===============================================================================
'  LinqHelper.DAO.DoiTuongToChucBase
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
	public class LqDoiTuongToChucBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDoiTuongToChucBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqDoiTuongToChucEntity obj)
		{
			provider.GetTable<LqDoiTuongToChucEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqDoiTuongToChucEntity _obj)
		{
			var q = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqDoiTuongToChucEntity tmp = q.First<LqDoiTuongToChucEntity>();
			
			tmp.IdDoiTuong = _obj.IdDoiTuong;
			tmp.IdToChuc = _obj.IdToChuc;
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
		
		public void Delete(LqDoiTuongToChucEntity obj)
		{
			provider.GetTable<LqDoiTuongToChucEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqDoiTuongToChucEntity ob = (LqDoiTuongToChucEntity)q.First<LqDoiTuongToChucEntity>();
            provider.GetTable<LqDoiTuongToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDoiTuong(Guid IdDoiTuong)
		{
			var q = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                    where obj.IdDoiTuong == IdDoiTuong
                    select obj;
					
            LqDoiTuongToChucEntity ob = (LqDoiTuongToChucEntity)q.First<LqDoiTuongToChucEntity>();
            provider.GetTable<LqDoiTuongToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdToChuc(Guid IdToChuc)
		{
			var q = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                    where obj.IdToChuc == IdToChuc
                    select obj;
					
            LqDoiTuongToChucEntity ob = (LqDoiTuongToChucEntity)q.First<LqDoiTuongToChucEntity>();
            provider.GetTable<LqDoiTuongToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqDoiTuongToChucEntity ob = (LqDoiTuongToChucEntity)q.First<LqDoiTuongToChucEntity>();
            provider.GetTable<LqDoiTuongToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqDoiTuongToChucEntity ob = (LqDoiTuongToChucEntity)q.First<LqDoiTuongToChucEntity>();
            provider.GetTable<LqDoiTuongToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqDoiTuongToChucEntity ob = (LqDoiTuongToChucEntity)q.First<LqDoiTuongToChucEntity>();
            provider.GetTable<LqDoiTuongToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqDoiTuongToChucEntity ob = (LqDoiTuongToChucEntity)q.First<LqDoiTuongToChucEntity>();
            provider.GetTable<LqDoiTuongToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqDoiTuongToChucEntity ob = (LqDoiTuongToChucEntity)q.First<LqDoiTuongToChucEntity>();
            provider.GetTable<LqDoiTuongToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqDoiTuongToChucEntity ob = (LqDoiTuongToChucEntity)q.First<LqDoiTuongToChucEntity>();
            provider.GetTable<LqDoiTuongToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqDoiTuongToChucEntity ob = (LqDoiTuongToChucEntity)q.First<LqDoiTuongToChucEntity>();
            provider.GetTable<LqDoiTuongToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqDoiTuongToChucEntity ob = (LqDoiTuongToChucEntity)q.First<LqDoiTuongToChucEntity>();
            provider.GetTable<LqDoiTuongToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqDoiTuongToChucEntity ob = (LqDoiTuongToChucEntity)q.First<LqDoiTuongToChucEntity>();
            provider.GetTable<LqDoiTuongToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqDoiTuongToChucEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqDoiTuongToChucEntity>();
		}

		public List<LqDoiTuongToChucEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                        select obj;
            return query.ToList<LqDoiTuongToChucEntity>();
		}
		
		
		public List<LqDoiTuongToChucEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqDoiTuongToChucEntity>();
		}
		
		
		public List<LqDoiTuongToChucEntity> SelectByIdDoiTuong(Guid IdDoiTuong)
		{
			var query = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                        where obj.IdDoiTuong == IdDoiTuong
                        select obj;
            return query.ToList<LqDoiTuongToChucEntity>();
		}
		
		
		public List<LqDoiTuongToChucEntity> SelectByIdToChuc(Guid IdToChuc)
		{
			var query = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                        where obj.IdToChuc == IdToChuc
                        select obj;
            return query.ToList<LqDoiTuongToChucEntity>();
		}
		
		
		public List<LqDoiTuongToChucEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqDoiTuongToChucEntity>();
		}
		
		
		public List<LqDoiTuongToChucEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqDoiTuongToChucEntity>();
		}
		
		
		public List<LqDoiTuongToChucEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqDoiTuongToChucEntity>();
		}
		
		
		public List<LqDoiTuongToChucEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqDoiTuongToChucEntity>();
		}
		
		
		public List<LqDoiTuongToChucEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqDoiTuongToChucEntity>();
		}
		
		
		public List<LqDoiTuongToChucEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqDoiTuongToChucEntity>();
		}
		
		
		public List<LqDoiTuongToChucEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqDoiTuongToChucEntity>();
		}
		
		
		public List<LqDoiTuongToChucEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqDoiTuongToChucEntity>();
		}
		
		
		public List<LqDoiTuongToChucEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqDoiTuongToChucEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqDoiTuongToChucEntity>();
		}
		
		
		

	}
}
