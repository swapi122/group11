




/*
'===============================================================================
'  LinqHelper.DAO.ThietHaiBase
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
	public class LqThietHaiBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqThietHaiBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqThietHaiEntity obj)
		{
			provider.GetTable<LqThietHaiEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqThietHaiEntity _obj)
		{
			var q = from obj in provider.GetTable<LqThietHaiEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqThietHaiEntity tmp = q.First<LqThietHaiEntity>();
			
			tmp.TenThietHai = _obj.TenThietHai;
			tmp.IdMaCha = _obj.IdMaCha;
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
		
		public void Delete(LqThietHaiEntity obj)
		{
			provider.GetTable<LqThietHaiEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqThietHaiEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqThietHaiEntity ob = (LqThietHaiEntity)q.First<LqThietHaiEntity>();
            provider.GetTable<LqThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenThietHai(string TenThietHai)
		{
			var q = from obj in provider.GetTable<LqThietHaiEntity>()
                    where obj.TenThietHai == TenThietHai
                    select obj;
					
            LqThietHaiEntity ob = (LqThietHaiEntity)q.First<LqThietHaiEntity>();
            provider.GetTable<LqThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdMaCha(Guid IdMaCha)
		{
			var q = from obj in provider.GetTable<LqThietHaiEntity>()
                    where obj.IdMaCha.Value == IdMaCha
                    select obj;
					
            LqThietHaiEntity ob = (LqThietHaiEntity)q.First<LqThietHaiEntity>();
            provider.GetTable<LqThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqThietHaiEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqThietHaiEntity ob = (LqThietHaiEntity)q.First<LqThietHaiEntity>();
            provider.GetTable<LqThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqThietHaiEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqThietHaiEntity ob = (LqThietHaiEntity)q.First<LqThietHaiEntity>();
            provider.GetTable<LqThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqThietHaiEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqThietHaiEntity ob = (LqThietHaiEntity)q.First<LqThietHaiEntity>();
            provider.GetTable<LqThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqThietHaiEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqThietHaiEntity ob = (LqThietHaiEntity)q.First<LqThietHaiEntity>();
            provider.GetTable<LqThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqThietHaiEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqThietHaiEntity ob = (LqThietHaiEntity)q.First<LqThietHaiEntity>();
            provider.GetTable<LqThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqThietHaiEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqThietHaiEntity ob = (LqThietHaiEntity)q.First<LqThietHaiEntity>();
            provider.GetTable<LqThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqThietHaiEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqThietHaiEntity ob = (LqThietHaiEntity)q.First<LqThietHaiEntity>();
            provider.GetTable<LqThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqThietHaiEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqThietHaiEntity ob = (LqThietHaiEntity)q.First<LqThietHaiEntity>();
            provider.GetTable<LqThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqThietHaiEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqThietHaiEntity ob = (LqThietHaiEntity)q.First<LqThietHaiEntity>();
            provider.GetTable<LqThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqThietHaiEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqThietHaiEntity ob = (LqThietHaiEntity)q.First<LqThietHaiEntity>();
            provider.GetTable<LqThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqThietHaiEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqThietHaiEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqThietHaiEntity>();
		}

		public List<LqThietHaiEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqThietHaiEntity>()
                        select obj;
            return query.ToList<LqThietHaiEntity>();
		}
		
		
		public List<LqThietHaiEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqThietHaiEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqThietHaiEntity>();
		}
		
		
		public List<LqThietHaiEntity> SelectByTenThietHai(string TenThietHai)
		{
			var query = from obj in provider.GetTable<LqThietHaiEntity>()
                        where obj.TenThietHai == TenThietHai
                        select obj;
            return query.ToList<LqThietHaiEntity>();
		}
		
		
		public List<LqThietHaiEntity> SelectByIdMaCha(Guid IdMaCha)
		{
			var query = from obj in provider.GetTable<LqThietHaiEntity>()
                        where obj.IdMaCha.Value == IdMaCha
                        select obj;
            return query.ToList<LqThietHaiEntity>();
		}
		
		
		public List<LqThietHaiEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqThietHaiEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqThietHaiEntity>();
		}
		
		
		public List<LqThietHaiEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqThietHaiEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqThietHaiEntity>();
		}
		
		
		public List<LqThietHaiEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqThietHaiEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqThietHaiEntity>();
		}
		
		
		public List<LqThietHaiEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqThietHaiEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqThietHaiEntity>();
		}
		
		
		public List<LqThietHaiEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqThietHaiEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqThietHaiEntity>();
		}
		
		
		public List<LqThietHaiEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqThietHaiEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqThietHaiEntity>();
		}
		
		
		public List<LqThietHaiEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqThietHaiEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqThietHaiEntity>();
		}
		
		
		public List<LqThietHaiEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqThietHaiEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqThietHaiEntity>();
		}
		
		
		public List<LqThietHaiEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqThietHaiEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqThietHaiEntity>();
		}
		
		
		public List<LqThietHaiEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqThietHaiEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqThietHaiEntity>();
		}
		
		
		

	}
}
