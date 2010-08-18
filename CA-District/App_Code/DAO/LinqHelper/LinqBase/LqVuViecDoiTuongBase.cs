




/*
'===============================================================================
'  LinqHelper.DAO.VuViecDoiTuongBase
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
	public class LqVuViecDoiTuongBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVuViecDoiTuongBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqVuViecDoiTuongEntity obj)
		{
			provider.GetTable<LqVuViecDoiTuongEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqVuViecDoiTuongEntity _obj)
		{
			var q = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqVuViecDoiTuongEntity tmp = q.First<LqVuViecDoiTuongEntity>();
			
			tmp.IdVuViec = _obj.IdVuViec;
			tmp.IdDoiTuong = _obj.IdDoiTuong;
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
		
		public void Delete(LqVuViecDoiTuongEntity obj)
		{
			provider.GetTable<LqVuViecDoiTuongEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqVuViecDoiTuongEntity ob = (LqVuViecDoiTuongEntity)q.First<LqVuViecDoiTuongEntity>();
            provider.GetTable<LqVuViecDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdVuViec(Guid IdVuViec)
		{
			var q = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                    where obj.IdVuViec == IdVuViec
                    select obj;
					
            LqVuViecDoiTuongEntity ob = (LqVuViecDoiTuongEntity)q.First<LqVuViecDoiTuongEntity>();
            provider.GetTable<LqVuViecDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDoiTuong(Guid IdDoiTuong)
		{
			var q = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                    where obj.IdDoiTuong == IdDoiTuong
                    select obj;
					
            LqVuViecDoiTuongEntity ob = (LqVuViecDoiTuongEntity)q.First<LqVuViecDoiTuongEntity>();
            provider.GetTable<LqVuViecDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqVuViecDoiTuongEntity ob = (LqVuViecDoiTuongEntity)q.First<LqVuViecDoiTuongEntity>();
            provider.GetTable<LqVuViecDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqVuViecDoiTuongEntity ob = (LqVuViecDoiTuongEntity)q.First<LqVuViecDoiTuongEntity>();
            provider.GetTable<LqVuViecDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqVuViecDoiTuongEntity ob = (LqVuViecDoiTuongEntity)q.First<LqVuViecDoiTuongEntity>();
            provider.GetTable<LqVuViecDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqVuViecDoiTuongEntity ob = (LqVuViecDoiTuongEntity)q.First<LqVuViecDoiTuongEntity>();
            provider.GetTable<LqVuViecDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqVuViecDoiTuongEntity ob = (LqVuViecDoiTuongEntity)q.First<LqVuViecDoiTuongEntity>();
            provider.GetTable<LqVuViecDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqVuViecDoiTuongEntity ob = (LqVuViecDoiTuongEntity)q.First<LqVuViecDoiTuongEntity>();
            provider.GetTable<LqVuViecDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqVuViecDoiTuongEntity ob = (LqVuViecDoiTuongEntity)q.First<LqVuViecDoiTuongEntity>();
            provider.GetTable<LqVuViecDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqVuViecDoiTuongEntity ob = (LqVuViecDoiTuongEntity)q.First<LqVuViecDoiTuongEntity>();
            provider.GetTable<LqVuViecDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqVuViecDoiTuongEntity ob = (LqVuViecDoiTuongEntity)q.First<LqVuViecDoiTuongEntity>();
            provider.GetTable<LqVuViecDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqVuViecDoiTuongEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqVuViecDoiTuongEntity>();
		}

		public List<LqVuViecDoiTuongEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                        select obj;
            return query.ToList<LqVuViecDoiTuongEntity>();
		}
		
		
		public List<LqVuViecDoiTuongEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqVuViecDoiTuongEntity>();
		}
		
		
		public List<LqVuViecDoiTuongEntity> SelectByIdVuViec(Guid IdVuViec)
		{
			var query = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                        where obj.IdVuViec == IdVuViec
                        select obj;
            return query.ToList<LqVuViecDoiTuongEntity>();
		}
		
		
		public List<LqVuViecDoiTuongEntity> SelectByIdDoiTuong(Guid IdDoiTuong)
		{
			var query = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                        where obj.IdDoiTuong == IdDoiTuong
                        select obj;
            return query.ToList<LqVuViecDoiTuongEntity>();
		}
		
		
		public List<LqVuViecDoiTuongEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqVuViecDoiTuongEntity>();
		}
		
		
		public List<LqVuViecDoiTuongEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqVuViecDoiTuongEntity>();
		}
		
		
		public List<LqVuViecDoiTuongEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqVuViecDoiTuongEntity>();
		}
		
		
		public List<LqVuViecDoiTuongEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqVuViecDoiTuongEntity>();
		}
		
		
		public List<LqVuViecDoiTuongEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqVuViecDoiTuongEntity>();
		}
		
		
		public List<LqVuViecDoiTuongEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqVuViecDoiTuongEntity>();
		}
		
		
		public List<LqVuViecDoiTuongEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqVuViecDoiTuongEntity>();
		}
		
		
		public List<LqVuViecDoiTuongEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqVuViecDoiTuongEntity>();
		}
		
		
		public List<LqVuViecDoiTuongEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqVuViecDoiTuongEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqVuViecDoiTuongEntity>();
		}
		
		
		

	}
}
