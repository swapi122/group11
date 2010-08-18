




/*
'===============================================================================
'  LinqHelper.DAO.DanhGiaTinBase
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
	public class LqDanhGiaTinBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDanhGiaTinBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqDanhGiaTinEntity obj)
		{
			provider.GetTable<LqDanhGiaTinEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqDanhGiaTinEntity _obj)
		{
			var q = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqDanhGiaTinEntity tmp = q.First<LqDanhGiaTinEntity>();
			
			tmp.TenDanhGiaTin = _obj.TenDanhGiaTin;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.MaTp = _obj.MaTp;
			tmp.GhiChu = _obj.GhiChu;
			tmp.LoaiDanhMuc = _obj.LoaiDanhMuc;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqDanhGiaTinEntity obj)
		{
			provider.GetTable<LqDanhGiaTinEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqDanhGiaTinEntity ob = (LqDanhGiaTinEntity)q.First<LqDanhGiaTinEntity>();
            provider.GetTable<LqDanhGiaTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenDanhGiaTin(string TenDanhGiaTin)
		{
			var q = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                    where obj.TenDanhGiaTin == TenDanhGiaTin
                    select obj;
					
            LqDanhGiaTinEntity ob = (LqDanhGiaTinEntity)q.First<LqDanhGiaTinEntity>();
            provider.GetTable<LqDanhGiaTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqDanhGiaTinEntity ob = (LqDanhGiaTinEntity)q.First<LqDanhGiaTinEntity>();
            provider.GetTable<LqDanhGiaTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqDanhGiaTinEntity ob = (LqDanhGiaTinEntity)q.First<LqDanhGiaTinEntity>();
            provider.GetTable<LqDanhGiaTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqDanhGiaTinEntity ob = (LqDanhGiaTinEntity)q.First<LqDanhGiaTinEntity>();
            provider.GetTable<LqDanhGiaTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqDanhGiaTinEntity ob = (LqDanhGiaTinEntity)q.First<LqDanhGiaTinEntity>();
            provider.GetTable<LqDanhGiaTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqDanhGiaTinEntity ob = (LqDanhGiaTinEntity)q.First<LqDanhGiaTinEntity>();
            provider.GetTable<LqDanhGiaTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqDanhGiaTinEntity ob = (LqDanhGiaTinEntity)q.First<LqDanhGiaTinEntity>();
            provider.GetTable<LqDanhGiaTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqDanhGiaTinEntity ob = (LqDanhGiaTinEntity)q.First<LqDanhGiaTinEntity>();
            provider.GetTable<LqDanhGiaTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqDanhGiaTinEntity ob = (LqDanhGiaTinEntity)q.First<LqDanhGiaTinEntity>();
            provider.GetTable<LqDanhGiaTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqDanhGiaTinEntity ob = (LqDanhGiaTinEntity)q.First<LqDanhGiaTinEntity>();
            provider.GetTable<LqDanhGiaTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqDanhGiaTinEntity ob = (LqDanhGiaTinEntity)q.First<LqDanhGiaTinEntity>();
            provider.GetTable<LqDanhGiaTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqDanhGiaTinEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqDanhGiaTinEntity>();
		}

		public List<LqDanhGiaTinEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                        select obj;
            return query.ToList<LqDanhGiaTinEntity>();
		}
		
		
		public List<LqDanhGiaTinEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqDanhGiaTinEntity>();
		}
		
		
		public List<LqDanhGiaTinEntity> SelectByTenDanhGiaTin(string TenDanhGiaTin)
		{
			var query = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                        where obj.TenDanhGiaTin == TenDanhGiaTin
                        select obj;
            return query.ToList<LqDanhGiaTinEntity>();
		}
		
		
		public List<LqDanhGiaTinEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqDanhGiaTinEntity>();
		}
		
		
		public List<LqDanhGiaTinEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqDanhGiaTinEntity>();
		}
		
		
		public List<LqDanhGiaTinEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqDanhGiaTinEntity>();
		}
		
		
		public List<LqDanhGiaTinEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqDanhGiaTinEntity>();
		}
		
		
		public List<LqDanhGiaTinEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqDanhGiaTinEntity>();
		}
		
		
		public List<LqDanhGiaTinEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqDanhGiaTinEntity>();
		}
		
		
		public List<LqDanhGiaTinEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqDanhGiaTinEntity>();
		}
		
		
		public List<LqDanhGiaTinEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqDanhGiaTinEntity>();
		}
		
		
		public List<LqDanhGiaTinEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqDanhGiaTinEntity>();
		}
		
		
		public List<LqDanhGiaTinEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqDanhGiaTinEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqDanhGiaTinEntity>();
		}
		
		
		

	}
}
